﻿using System;
namespace SanJing
{
    public class Const
    {
        public const string DATE_YYYYMMDD = "yyyy-MM-dd";
        public const string DATE_YYYYMMDDHHMM = "yyyy-MM-dd HH:mm";
        public const string DATE_YYYYMMDDHHMMSS = "yyyy-MM-dd HH:mm:ss";
        /// <summary>
        /// 随机种子
        /// </summary>
        public static Random RANDOM_SEED = new Random();
    }
}

namespace System
{
    public static class SanJingDateTime
    {
        /// <summary>
        /// 将当前 DateTime 对象的值转换为Unix时间戳
        /// </summary>
        /// <param name="owner"></param>
        /// <returns></returns>
        public static long ToUnixTimestamp(this DateTime owner)
        {
            return (owner.Ticks - 621356256000000000) / 10000;
        }
        /// <summary>
        /// 将Unix时间戳转换为 DateTime
        /// </summary>
        /// <param name="timestamp"></param>
        /// <returns></returns>
        public static DateTime Parse(long timestamp)
        {
            return new DateTime(timestamp * 10000 + 621356256000000000);
        }
        /// <summary>
        /// 将Unix时间戳转换为 DateTime
        /// </summary>
        /// <param name="timestamp"></param>
        /// <returns></returns>
        public static DateTime Parse(string timestamp)
        {
            return Parse(long.Parse(timestamp));
        }
    }
}
