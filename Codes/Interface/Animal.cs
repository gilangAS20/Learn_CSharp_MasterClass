namespace Interface;

public class Animal : IAnimal
{
    private string _animalSound = "";
    
    public virtual string GetSound()
    {
        return _animalSound;
    }

    public virtual void SetSound(string sound)
    {
        _animalSound = sound;
    }
}