﻿// XAML Map Control - http://xamlmapcontrol.codeplex.com/
// Copyright © Clemens Fischer 2012-2013
// Licensed under the Microsoft Public License (Ms-PL)

#if NETFX_CORE
using Windows.UI.Xaml.Media;
#else
using System.Windows.Media;
#endif

namespace MapControl
{
    public partial class MapImage
    {
        private static readonly Transform imageTransform = new MatrixTransform
        {
            Matrix = new Matrix(1d, 0d, 0d, -1d, 0d, 1d)
        };

        private void SourceChanged(ImageSource image)
        {
            Fill = new ImageBrush
            {
                ImageSource = image,
                RelativeTransform = imageTransform
            };
        }
    }
}
