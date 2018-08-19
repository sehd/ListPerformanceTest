using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ListPerformanceTest.Business;

namespace ListPerformanceTest.AndroidNative
{
    static class Extensions
    {
        public static string Serialize(this DataItem item)
        {
            return $"{item.ImageId}|{item.Name}";
        }

        public static DataItem Deserialize(this string serialized)
        {
            var subs = serialized.Split('|');
            return new DataItem()
            {
                ImageId = int.Parse(subs[0]),
                Name = subs[1]
            };
        }

        private static Dictionary<int, int> resourceAvatarMap;
        public static int GetResourceId(this int imageId)
        {
            if (resourceAvatarMap == null)
                resourceAvatarMap = new Dictionary<int, int>
                {
                    { 1 , Resource.Mipmap.avatar1 },
                    { 2 , Resource.Mipmap.avatar2 },
                    { 3 , Resource.Mipmap.avatar3 },
                    { 4 , Resource.Mipmap.avatar4 },
                    { 5 , Resource.Mipmap.avatar5 },
                    { 6 , Resource.Mipmap.avatar6 },
                    { 7 , Resource.Mipmap.avatar7 },
                    { 8 , Resource.Mipmap.avatar8 },
                    { 9 , Resource.Mipmap.avatar9 },
                    { 10 , Resource.Mipmap.avatar10 },
                    { 11 , Resource.Mipmap.avatar11 },
                    { 12 , Resource.Mipmap.avatar12 },
                    { 13 , Resource.Mipmap.avatar13 },
                    { 14 , Resource.Mipmap.avatar14 },
                    { 15 , Resource.Mipmap.avatar15 },
                    { 16 , Resource.Mipmap.avatar16 },
                    { 17 , Resource.Mipmap.avatar17 },
                    { 18 , Resource.Mipmap.avatar18 },
                    { 19 , Resource.Mipmap.avatar19 },
                    { 20 , Resource.Mipmap.avatar20 },
                    { 21 , Resource.Mipmap.avatar21 },
                    { 22 , Resource.Mipmap.avatar22 },
                    { 23 , Resource.Mipmap.avatar23 },
                    { 24 , Resource.Mipmap.avatar24 },
                    { 25 , Resource.Mipmap.avatar25 },
                    { 26 , Resource.Mipmap.avatar26 },
                    { 27 , Resource.Mipmap.avatar27 },
                    { 28 , Resource.Mipmap.avatar28 },
                    { 29 , Resource.Mipmap.avatar29 },
                    { 30 , Resource.Mipmap.avatar30 },
                    { 31 , Resource.Mipmap.avatar31 },
                    { 32 , Resource.Mipmap.avatar32 },
                    { 33 , Resource.Mipmap.avatar33 },
                    { 34 , Resource.Mipmap.avatar34 },
                    { 35 , Resource.Mipmap.avatar35 },
                    { 36 , Resource.Mipmap.avatar36 },
                    { 37 , Resource.Mipmap.avatar37 },
                    { 38 , Resource.Mipmap.avatar38 },
                    { 39 , Resource.Mipmap.avatar39 },
                    { 40 , Resource.Mipmap.avatar40 },
                    { 41 , Resource.Mipmap.avatar41 },
                    { 42 , Resource.Mipmap.avatar42 },
                    { 43 , Resource.Mipmap.avatar43 },
                    { 44 , Resource.Mipmap.avatar44 },
                    { 45 , Resource.Mipmap.avatar45 },
                };

            if (resourceAvatarMap.ContainsKey(imageId))
                return resourceAvatarMap[imageId];
            else
                return 0;
        }
    }
}