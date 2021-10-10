using CleanDotnet.Application.Common.Interfaces;
using System;

namespace CleanDotnet.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
