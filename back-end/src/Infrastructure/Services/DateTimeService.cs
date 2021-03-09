using XRM.Application.Common.Interfaces;
using System;

namespace XRM.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
