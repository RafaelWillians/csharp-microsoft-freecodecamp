int playerHP = 10;
int monsterHP = 10;
int turnCount = 1;
int damage = 0;

Random randomNumber = new Random();

Console.WriteLine("A random monster appears!\n");

do{
    damage = randomNumber.Next(1,10);
    switch(turnCount)
    {
        case 1: 
            monsterHP-= damage;
            // Caso o HP fique menor que zero, se torna zero.            
            Console.WriteLine($"Monster took {damage} damage and now has {(monsterHP < 0 ? monsterHP = 0 : monsterHP)} HP.\n");
            turnCount = 2;
            break;           
            
        case 2:        
            playerHP-= damage;
            // Caso o HP fique menor que zero, se torna zero.
            Console.WriteLine($"You took {damage} damage and now have {(playerHP < 0 ? playerHP = 0 : playerHP)} HP.\n");
            turnCount = 1;         
            break;
        default:
            Console.WriteLine("The attack failed!");            
            break;

    }
    // Para checar se é dano crítico ou dano baixo.
    switch(damage)
    {
        case >= 7:
            Console.WriteLine("A critical hit!\n");
            break;
        case <= 2:
            Console.WriteLine("It's not very effective!\n");
            break;        
    }
    
} while (playerHP >= 1 && monsterHP >=1);

Console.WriteLine($"{(monsterHP <= 0 ? "You won the battle!" : "The monster won the battle! GAME OVER" )}");



