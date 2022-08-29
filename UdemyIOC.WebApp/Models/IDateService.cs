using System;

namespace UdemyIOC.WebApp.Models
{
    public interface IDateService
    {
        DateTime GetDateTime { get; }
    }
    public interface ISingletonDateService : IDateService { }
    public interface IScopedDateService : IDateService { }
    public interface ITransientDateService : IDateService { }
}