﻿namespace TestTask.DAL.Constants;

internal static class EducationForms
{
    public const string Budget = nameof(Budget);
    public const string Contract = nameof(Contract);

    public static IEnumerable<string> Enumerate()
    {
        yield return Budget;
        yield return Contract;
    }
}