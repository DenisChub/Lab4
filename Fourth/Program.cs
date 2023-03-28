namespace Fourth
{

    class Action1 { }
    class Action2 { }
    class Action3 { }

    enum State
    {
        Start,
        Action1Completed,
        Action2Completed,
        Action3Completed,
        End
    }

    delegate void WorkflowEvent();

    class Workflow
    {
        private State currentState = State.Start;

       
        private Dictionary<State, WorkflowEvent> eventHandlers = new Dictionary<State, WorkflowEvent>();

        
        public void AddEventHandlers()
        {
            eventHandlers[State.Start] = () => { Console.WriteLine("Початок робочого процесу"); currentState = State.Action1Completed; };
            eventHandlers[State.Action1Completed] = () => { Console.WriteLine("Дія 1 виконана"); currentState = State.Action2Completed; };
            eventHandlers[State.Action2Completed] = () => { Console.WriteLine("Дія 2 виконана"); currentState = State.Action3Completed; };
            eventHandlers[State.Action3Completed] = () => { Console.WriteLine("Дія 3 виконана"); currentState = State.End; };
            eventHandlers[State.End] = () => { Console.WriteLine("Робочий процес завершено"); };
        }

        public void TriggerWorkflow()
        {
            while (currentState != State.End)
            {
                eventHandlers[currentState]?.Invoke();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Workflow workflow = new Workflow();
            workflow.AddEventHandlers();

            workflow.TriggerWorkflow();

            Console.ReadLine();
        }
    }
}