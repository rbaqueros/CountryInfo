/*
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

namespace CountryInfo
{
    public class Country : IComparable
    {
        public Country(string iso2Code, string countryName, BitmapImage countryFlag)
        {
            Iso2 = iso2Code;
            Name = countryName;
            Flag = countryFlag;

        }

        private string _iso2;

        public string Iso2
        {
            get { return _iso2; }
            set { _iso2 = value; }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private BitmapImage _flag;

        public BitmapImage Flag
        {
            get { return _flag; }
            set { _flag = value; }
        }

        public override string ToString()
        {
            return _name.ToString();
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Country otherCountry = obj as Country;
            if(otherCountry==null)
            {
                throw new ArgumentException("Unable to compare. Object is not of type country");
            }
            return Name.CompareTo(otherCountry.Name);
        }
    }
}
