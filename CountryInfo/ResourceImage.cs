﻿/*
 * Copyright (c) 2015 Rafael Baquero
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Baqsoft.CountryInfo
{
    class ResourceImage
    {
        public static BitmapImage GetEmbeddedBitmapResource(string resourcePath)
        {
            string imgUri = String.Format(@"pack://application:,,,/CountryInfo;component/Resources/Flags/{0}", resourcePath);
            BitmapImage img = new BitmapImage(new Uri(imgUri, UriKind.RelativeOrAbsolute));

            return img;
        }
    }
}
