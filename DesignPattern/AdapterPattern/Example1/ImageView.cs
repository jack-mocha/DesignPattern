using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AdapterPattern.Example1
{
    public class ImageView
    {
        private Image _image;

        public ImageView(Image image)
        {
            _image = image;
        }

        public void Apply(IFilter filter)
        {
            filter.Apply(_image);
        }
    }
}
