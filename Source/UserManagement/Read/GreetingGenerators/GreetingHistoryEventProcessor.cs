using doLittle.Events.Processing;
using Events.DataCollector;

namespace Read.GreetingGenerators
{
    public class GreetingHistoryEventProcessor : ICanProcessEvents 
    {
        readonly IGreetingHistories _greetingHistories;

        public GreetingHistoryEventProcessor(IGreetingHistories greetingHistories)
        {
            _greetingHistories = greetingHistories;
        }
        /* //TODO: What is even this class? Seems obsolete?
        public async void Process(PhoneNumberAddedToDataCollector @event)
        {
            var greetingHistory = await _greetingHistories.GetByPhoneNumberAsync(@event.PhoneNumber) ?? new GreetingHistory(@event.Id);
            greetingHistory.PhoneNumber = @event.PhoneNumber;
           await _greetingHistories.SaveAsync(greetingHistory);
        }

        public async void Process(PhoneNumberRemovedFromDataCollector @event)
        {
            await _greetingHistories.RemoveAsync(@event.PhoneNumber);
        }
        */ 
    }
}
