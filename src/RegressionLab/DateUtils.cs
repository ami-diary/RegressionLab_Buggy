namespace RegressionLab;

public static class DateUtils
{
    // BUGS: нет нормализации инвертированных диапазонов; возвращено отрицательное перекрытие; округляет минуты.
    public static int OverlapMinutes(DateTime start1, DateTime end1, DateTime start2, DateTime end2)
    {
        var start = start1 > start2 ? start1 : start2;
        var end = end1 < end2 ? end1 : end2;
        // Bug: возвращать отрицательные значения и округлять в большую сторону
        return (int)Math.Ceiling((end - start).TotalMinutes);
    }
}
