/*
MIT License

Copyright(c) 2021 Kyle Givler
https://github.com/JoyfulReaper

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

using DiscordBotLib.Extensions;
using Serilog;
using System;

namespace DiscordBotLib.Helpers
{
    public static class ImageLookupUtility
    {
        public static readonly string[] BAN_IMAGES = new string[0];

        public static readonly string[] UNBAN_IMAGES = new string[0];

        public static readonly string[] QUIT_IMAGES = new string[0];

        public static readonly string[] BADCOMMAND_IMAGES = new string[0];

        public static readonly string[] LOGGING_IMAGES = new string[0];

        public static readonly string[] EIGHTBALL_IMAGES = new string[0];

        public static readonly string[] COIN_IMAGES = new string[0];

        public static readonly string[] DIE_IMAGES = new string[0];

        public static readonly string[] GUN_IMAGES = new string[0];

        public static readonly string[] MATH_IMAGES = new string[0];

        public static readonly string[] KICK_IMAGES = new string[0];

        public static readonly string[] PURGE_IMAGES = new string[0];

        public static readonly string[] PREFIX_IMAGES = new string[0];

        public static readonly string[] ERROR_IMAGES = new string[0];

        public static readonly string[] MUTE_IMAGES = new string[0];

        public static readonly string[] UNMUTE_IMAGES = new string[0];

        public static readonly string[] SEARCH_IMAGES = new string[0];

        public static readonly string[] NOTE_IMAGES = new string[0];

        public static readonly string[] HELP_IMAGES = new string[0];

        public static readonly string[] BROADCAST_IMAGES = new string[0];

        public static readonly string[] INVITE_IMAGES = new string[0];

        private static readonly Random _random = new Random();

        public static string GetImageUrl(string key)
        {
            var logger = Log.ForContext(typeof(ImageLookupUtility));

            Type type = typeof(ImageLookupUtility);
            var fieldInfo = type.GetField(key);

            if(fieldInfo == null)
            {
                logger.Warning("Key: {key} not found!", key);
                return null;
            }

            string[] urlArray = (string[])fieldInfo.GetValue(null);
            string imageUrl = urlArray.RandomItem();

            logger.Information("Sending image: {imageurl}", imageUrl);

            return imageUrl;
        }
    }
}
