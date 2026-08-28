public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>(); 
        int right;
        int left;
        foreach (string token in tokens)
        {
            if (!IsOperator(token))
            {
                stack.Push(int.Parse(token));
            }
            else
            {
                switch (token)
                {
                    case "+":
                        stack.Push(stack.Pop() + stack.Pop());
                        break;
                    case "*":
                        stack.Push(stack.Pop() * stack.Pop());
                        break;
                    case "/":
                        right = stack.Pop();
                        left = stack.Pop();
                        stack.Push(left / right);
                        break;
                    case "-":
                        right = stack.Pop();
                        left = stack.Pop();
                        stack.Push(left - right);
                        break;
                }
            }
        }
        return stack.Pop();
    }
    private bool IsOperator(string c)
    {
        return c == "+" || c == "*" || c == "-" || c == "/";
    }   
}
