﻿using System;
using System.Collections;

public class StringDisperser : ICloneable, IComparable, IEnumerable
{
    private string[] strings;

    public StringDisperser(params string[] strings)
    {
        this.strings = strings;
    }

    public override string ToString()
    {
        return string.Join("", this.strings);
    }

    public override bool Equals(object obj)
    {
        return this.ToString() == ((StringDisperser)obj).ToString();
    }

    public override int GetHashCode()
    {
        return this.GetHashCode();
    }

    public static bool operator ==(StringDisperser a, StringDisperser b)
    {
        if (ReferenceEquals(a, b))
        {
            return true;
        }

        if (((object)a == null) || ((object)b == null))
        {
            return false;
        }
        return a.ToString() == b.ToString();
    }

    public static bool operator !=(StringDisperser a, StringDisperser b)
    {
        return !(a == b);
    }

    public object Clone()
    {
        return new StringDisperser((string[])this.strings.Clone());
    }

    public int CompareTo(object obj)
    {
        return this.ToString().CompareTo(obj.ToString());
    }

    public IEnumerator GetEnumerator()
    {
        var str = this.ToString();
        for (var i = 0; i < str.Length; i++)
        {
            yield return str[i];
        }
    }
}