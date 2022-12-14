namespace TimeZoneHelper
{
    public static class DateTimeHelper
    {
        /// <summary>
        /// This method convert the currentTime to a speficic TimeZone
        /// </summary>
        /// <param name="timeZoneId"></param>
        /// <returns>A DateTime for the specific TimeZoneId provided</returns>
        /// <exception cref="ArgumentException"></exception>
        public static DateTime GetDateTimeByTimeZoneId(string timeZoneId)
        {
            var timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);

            if (timeZoneInfo == null) throw new ArgumentException($"Not TimeZoneInfo was founded with the id {timeZoneId}");

            var current = TimeZone.CurrentTimeZone.ToUniversalTime(DateTime.Now);
            return TimeZoneInfo.ConvertTimeFromUtc(current, timeZoneInfo);
        }
    }
}