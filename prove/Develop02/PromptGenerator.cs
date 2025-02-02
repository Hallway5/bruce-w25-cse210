public class PromptGenerator {

    //public List<string> _prompts = new List<string>();

    public string GetRandomPrompt() {

        Random randomGenerator = new Random();
        int promptNumber = randomGenerator.Next(1, 5);

        string prompt = "";

        if (promptNumber == 1) {
            prompt = "What was the most interesting thing to happen today?";
        }
        if (promptNumber == 2) {
            prompt = "What was the funniest thing to happen today?";
        }
        if (promptNumber == 3) {
            prompt = "What was the best thing to happen today?";
        }
        if (promptNumber == 4) {
            prompt = "What was the worst thing to happen today?";
        }
        if (promptNumber == 5) {
            prompt = "What was the least interesting thing to happen today?";
        }

        return prompt;
    }
}