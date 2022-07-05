﻿using System.Diagnostics;
using Bit.TodoTemplatePlayground.App.Shared;

namespace Bit.TodoTemplatePlayground.App.Services.Implementations;

public class ExceptionHandler : IExceptionHandler
{
    public void Handle(Exception exception, IDictionary<string, object?>? parameters = null)
    {
#if DEBUG
        MessageBox.Show(exception.ToString(), "Error");
        Console.WriteLine(exception.ToString());
        Debugger.Break();
#else
        if (exception is KnownException)
        {
            MessageBox.Show(exception.Message, "Error");
        }
        else
        {
            MessageBox.Show("Unknown error.", "Error");
        }
#endif

    }
}
