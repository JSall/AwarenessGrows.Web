using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace AwarenessGrows.Web.Helpers
{
    public static class JsonExtensions
    {
        /// <summary>
        /// Used for List<string>/"tags" coming from Views if multiple tags in string[0]
        /// </summary>
        /// <param name="list">List<string></param>
        /// <returns>List<string></returns>
        public static List<string> DeserializeStringList(this List<string> list)
        {

            try
            {
                // not null or 0 or "" && has json string array in [0] and hasn't been converted before (count will equal 1 in that case and not "")
                if (list != null && list.Count != 0 && list.Count == 1 && !string.IsNullOrEmpty(list[0]))
                {
                    if (list[0].Contains("["))
                    {
                        list = JsonConvert.DeserializeObject<List<string>>(list[0]);
                    }
                }
            }
            catch (Exception e)
            {
                // TODO: logger??
            }
            return list;
        }

        public static string TagsToString(this string tags)
        {

            try
            {
                // not null or 0 or "" && has json string array in [0] and hasn't been converted before (count will equal 1 in that case and not "")
                if (tags != null && !string.IsNullOrEmpty(tags))
                {
                    if (tags.Contains("["))
                    {
                        tags = JsonConvert.DeserializeObject<string>(tags);
                    }
                }
            }
            catch (Exception e)
            {
                // TODO: logger??
            }
            return tags;
        }

    }
}