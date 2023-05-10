using CountDownTimer2.Data;
using Microsoft.EntityFrameworkCore;

namespace CountDownTimer2.Data
{
    public class TimerService
    {
        private readonly TimerDbContext _timerDbContext;

        public TimerService(TimerDbContext timerDbContext)
        {
            _timerDbContext = timerDbContext;
        }

        public async Task<List<TimerEntity>> GetAllTimerEntitiesAsync()
        {
            return await _timerDbContext.TimerEntities.ToListAsync();
        }

        public async Task<bool> InsertTimer(TimerEntity timer)
        {
            _timerDbContext.TimerEntities.Add(timer);
            _timerDbContext.SaveChanges();
            return true;
        }
    }
}
