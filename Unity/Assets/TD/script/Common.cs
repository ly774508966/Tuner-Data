﻿/*
   Tuner Data -  Read Static Data in Game Development.
   e-mail : dongliang17@126.com
*/
namespace TD
{
    /// <summary>
    /// field type
    /// </summary>
    public enum FIELD_TYPE
    {
        T_INT = 0,
        T_FLOAT = 1,
        T_STRING = 2,
        T_INVALID = -1
    };
    public class Util
    {
        /// <summary>
        /// make sure path Has been created.
        /// </summary>
        /// <param name="localPath">path</param>
        /// <returns>path</returns>
        static public string CreateDirectory(string localPath)
        {
            string path = localPath;
            if (System.IO.Directory.Exists(path) == false)
            {
                System.IO.Directory.CreateDirectory(path);
            }
            return path;
        }
    }
}