using System;
using GapTraderCore.Interfaces;
using MvvmArchitecture.Interfaces;

namespace GapTraderWpf;

public class Runner : IRunner
{
    public Runner(IContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    private readonly IContext _context;
}