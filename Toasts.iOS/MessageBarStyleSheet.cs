//
// DefaultMessageBarStyleSheet.cs
//
// Author:
//       Prashant Cholachagudda <pvc@outlook.com>
//
// Copyright (c) 2013 Prashant Cholachagudda
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.


using UIKit;

namespace Toasts.iOS
{
    public class MessageBarStyleSheet 
    {
        private const float Alpha = 0.96f;
        private const string InfoIcon = "icon-info.png";
        private const string SuccessIcon = "icon-success.png";
        private const string WarningIcon = "icon-warning.png";
        private const string ErrorIcon = "icon-error.png";

        private readonly UIColor _infoBackgroundColor;
        private readonly UIColor _successBackgroundColor;
        private readonly UIColor _warningBackgroundColor;
        private readonly UIColor _errorBackgroundColor;

        private readonly UIColor _infoStrokeColor;
        private readonly UIColor _successStrokeColor;
        private readonly UIColor _warningStrokeColor;
        private readonly UIColor _errorStrokeColor;

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageBarStyleSheet"/> class.
        /// </summary>
        public MessageBarStyleSheet ()
        {
            _infoBackgroundColor = UIColor.FromRGBA(101 / 255.0f, 135 / 255.0f, 185 / 255.0f, Alpha);
            _successBackgroundColor = UIColor.FromRGBA(65 / 255.0f, 182 / 255.0f, 103 / 255.0f, Alpha);
            _warningBackgroundColor = UIColor.FromRGBA(255 / 255.0f, 210 / 255.0f, 1 / 255.0f, Alpha);
            _errorBackgroundColor = UIColor.FromRGBA(210 / 255.0f, 10 / 255.0f, 10 / 255.0f, Alpha);

            _infoStrokeColor = UIColor.FromRGBA(101 / 255.0f, 135 / 255.0f, 185 / 255.0f, Alpha);
            _successStrokeColor = UIColor.FromRGBA(65 / 255.0f, 182 / 255.0f, 103 / 255.0f, Alpha);
            _warningStrokeColor = UIColor.FromRGBA(255 / 255.0f, 210 / 255.0f, 1 / 255.0f, Alpha);
            _errorStrokeColor = UIColor.FromRGBA(210 / 255.0f, 10 / 255.0f, 10 / 255.0f, Alpha);
        }

        /// <summary>
        /// Provides the background colour for message type
        /// </summary>
        /// <returns>The background colour for message type.</returns>
        /// <param name="type">Message type</param>
        public virtual UIColor BackgroundColorForMessageType(ToastNotificationType type)
        {
            UIColor backgroundColor = null;
            switch (type)
            {
                case ToastNotificationType.Info:
                    backgroundColor = _infoBackgroundColor;
                    break;
                case ToastNotificationType.Success:
                    backgroundColor = _successBackgroundColor;
                    break;
                case ToastNotificationType.Warning:
                    backgroundColor = _warningBackgroundColor;
                    break;
                case ToastNotificationType.Error:
                    backgroundColor = _errorBackgroundColor;
                    break;
            }

            return backgroundColor;
        }

        /// <summary>
        /// Provides the stroke colour for message type
        /// </summary>
        /// <returns>The stroke colour for message type.</returns>
        /// <param name="type">Message type</param>
        public virtual UIColor StrokeColorForMessageType(ToastNotificationType type)
        {
            UIColor strokeColor = null;
            switch (type)
            {
                case ToastNotificationType.Info:
                    strokeColor = _infoStrokeColor;
                    break;
                case ToastNotificationType.Success:
                    strokeColor = _successStrokeColor;
                    break;
                case ToastNotificationType.Warning:
                    strokeColor = _warningStrokeColor;
                    break;
                case ToastNotificationType.Error:
                    strokeColor = _errorStrokeColor;
                    break;
            }

            return strokeColor;
        }

        /// <summary>
        /// Provides the icon for message type
        /// </summary>
        /// <returns>The icon for message type.</returns>
        /// <param name="type">Message type</param>
        public virtual UIImage IconImageForMessageType(ToastNotificationType type)
        {
            UIImage iconImage = null;
            switch (type)
            {
                case ToastNotificationType.Info:
                    iconImage = UIImage.FromBundle(InfoIcon);
                    break;
                case ToastNotificationType.Success:
                    iconImage = UIImage.FromBundle(SuccessIcon);
                    break;
                case ToastNotificationType.Warning:
                    iconImage = UIImage.FromBundle(WarningIcon);
                    break;
                case ToastNotificationType.Error:
                    iconImage = UIImage.FromBundle(ErrorIcon);
                    break; 
            }

            return iconImage;
        }
    }
}
