using System;

class InteractionSystem
{
    public void InteractAll(List<IInteractable> items)
    {
        foreach (IInteractable item in items)
        {
            Console.WriteLine($"[{item.Prompt}]");
            item.Interact();
        }
    }
}