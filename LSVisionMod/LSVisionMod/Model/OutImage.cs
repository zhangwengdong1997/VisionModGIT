using HalconDotNet;
using LSVisionMod.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSVisionMod.Model
{
    public class OutImage
    {
        public string CamName { get; set; }
        private HObject _hoImage;
        private Bitmap _bmpImage;
        public HObject HoImage
        {
            get
            {
                if (_hoImage != null)
                {
                    return _hoImage;
                }
                else if (_bmpImage != null)
                {
                    return ChangeImageType.Bitmap2Honject(_bmpImage);
                }
                else
                {
                    return null;
                }
            }
            set
            {
                _hoImage = value;
            }
        }
        public Bitmap BmpImage
        {
            get
            {   if(_bmpImage != null)
                {
                    return _bmpImage;
                }
                else if(_hoImage != null)
                {
                    return ChangeImageType.Honject2Bitmap(_hoImage);
                }
                else
                {
                    return null;
                }
            }
            set
            {
                _bmpImage = value;
            }
        }
        public OutImage(string camName, HObject ho_Image)
        {
            this.CamName = camName;
            this._hoImage = new HObject(ho_Image);
        }

        public OutImage(string camName, Bitmap bitmap)
        {
            this.CamName = camName;
            this._bmpImage = new Bitmap(bitmap);
        }

        ~OutImage()
        {
            if(_hoImage != null)
            {
                _hoImage.Dispose();
            }
            if(_bmpImage != null)
            {
                _bmpImage.Dispose();
            }
        }

        public bool WriteImage(string path, string name)
        {
            if (_hoImage != null)
            {
                try
                {
                    HOperatorSet.WriteImage(_hoImage, "jpg", 0, path + "\\" + name);
                }
                catch
                {
                    throw;
                }
                return true;
            }
            if (_bmpImage != null)
            {
                try
                {
                    _bmpImage.Save(path + "\\" + name);
                }
                catch
                {
                    throw;
                }
                return true;
            }
            return false;
        }
    }
}
