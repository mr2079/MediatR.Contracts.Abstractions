﻿namespace MediatR.Contracts.Abstractions;

public sealed record Error(string Code, string Message)
{
    public static Error None = new(string.Empty, string.Empty);
    public static Error NullValue = new("Error.NullValue", "Null value");
}