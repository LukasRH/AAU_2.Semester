long gotodiff_se(long x, long y)
{
    long t = x-y;
    long result;
    long lt_count = 0;
    long ge_count = 0;

    if (t)
    {
        goto True;
    }
    else
    {
        goto Done;
    }


    True; ge_count++;
        result = x - y;
        return result;


    Done; lt_count++
        result = y-x;
        return result;
}