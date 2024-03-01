// See https://aka.ms/new-console-template for more information


//Cat, Dog, Bird, Fish
//Properties: Nickname, Age, Gender, Energy, Price, MealQuantity
//Methods: Eat(), Sleep(), Play()


Cat cat1 = new Cat("cat1",1,"male",70,10,6);   
Cat cat2 = new Cat("cat2",2,"male",30,16,5);   
Cat cat3 = new Cat("cat3",3,"female",75,14,2);   
Cat cat4 = new Cat("cat4",4,"female",10,11,4);   
Cat cat5 = new Cat("cat5",5,"male",20,9,2);

Dog dog1 = new Dog("dog1", 1, "male", 70, 10, 6);
Dog dog2 = new Dog("dog2", 2, "male", 30, 16, 5);
Dog dog3 = new Dog("dog3", 3, "female", 75, 14, 2);
Dog dog4 = new Dog("dog4", 4, "female", 10, 11, 4);
Dog dog5 = new Dog("dog5", 5, "male", 20, 9, 2);

Bird bird1 = new Bird("bird1", 1, "male", 70, 10, 6);
Bird bird2 = new Bird("bird2", 2, "male", 30, 16, 5);
Bird bird3 = new Bird("bird3", 3, "female", 75, 14, 2);
Bird bird4 = new Bird("bird4", 4, "female", 10, 11, 4);
Bird bird5 = new Bird("bird5", 5, "male", 20, 9, 2);

Fish fish1 = new Fish("fish1", 1, "male", 70, 10, 6);
Fish fish2 = new Fish("fish2", 2, "male", 30, 16, 5);
Fish fish3 = new Fish("fish3", 3, "female", 75, 14, 2);
Fish fish4 = new Fish("fish4", 4, "female", 10, 11, 4);
Fish fish5 = new Fish("fish5", 5, "male", 20, 9, 3);



PetShop ps=new PetShop();


ps.add_Cat(cat1);
ps.add_Cat(cat2);
ps.add_Cat(cat3);
ps.add_Cat(cat4);
ps.add_Cat(cat5);

ps.add_Dog(dog1);
ps.add_Dog(dog2);
ps.add_Dog(dog3);
ps.add_Dog(dog4);
ps.add_Dog(dog5);

ps.add_Bird(bird1);
ps.add_Bird(bird2);
ps.add_Bird(bird3);
ps.add_Bird(bird4);
ps.add_Bird(bird5);

ps.add_Fish(fish1);
ps.add_Fish(fish2);
ps.add_Fish(fish3);
ps.add_Fish(fish4);
ps.add_Fish(fish5);

//ps.Show_all_cats();
//Console.WriteLine("----------------------------");
//ps.RemoveByNickName_cat("cat1");
//ps.Show_all_cats();
/// <summary>
/// //////////////////////////////////////////////////////////////////// Idare etme
/// </summary>
//ps.all_Prices();
//Console.WriteLine(  " -------------------------");
//ps.all_Foots();


class Animal
{
    public string Nickname { get; set; }
    public int Age { get; set; }
    public string gender { get; set; }
    public double Energy { get; set; }
    public double Price { get; set; }
    public int MealQuantity { get; set; }

    public Animal()
    {
        this.Nickname = string.Empty;
        this.Age = 0;
        this.gender = string.Empty;
        this.Energy = 0;
        this.Price = 0;
        this.MealQuantity = 0;
    }

    public Animal(string nickname, int age, string gender, double energy, double price, int mealquantity)
    {
        this.Nickname = nickname;
        this.Age = age;
        this.gender = gender;
        this.Energy = energy;
        this.Price = price;
        this.MealQuantity = mealquantity;
    }

    public virtual void Eat()
    {
        if (Energy != 100)
        {
            if (this.Energy + 10 > 100)
            {
                this.Energy = 100;
            }
            else
            {
                this.Energy += 10;
            }
        }
        this.Price += 1;
        this.MealQuantity += 1;
        Console.WriteLine(" Animal Eat ");
    }

    public virtual void Sleep()
    {
        if (Energy != 100)
        {
            if (this.Energy + 70 > 100)
            {
                this.Energy = 100;
            }
            else
            {
                this.Energy += 70;
            }
        }

        this.Price += 1;
        this.MealQuantity += 1;
        Console.WriteLine(" Animal sleep ");
    }

    public virtual void Play()
    {
        if (this.Energy - 20 >= 0)
        {
            this.Energy -= 20;
        }
        else
        {
            this.Energy = 0;
        }
        Console.WriteLine(" Animal played ");
        if (this.Energy == 0)
        {
            this.Sleep();
        }
    }

    public void Show()
    {
        Console.WriteLine($" Nickname : {this.Nickname}");
        Console.WriteLine($" Age : {this.Age}");
        Console.WriteLine($" Gender : {this.gender}");
        Console.WriteLine($" Energy : {this.Energy}");
        Console.WriteLine($" Price : {this.Price}");
        Console.WriteLine($" MealQuantity : {this.MealQuantity}");
    }

}

class Cat : Animal
{
    public Cat()
    {
        this.Nickname = string.Empty;
        this.Age = 0;
        this.gender = string.Empty;
        this.Energy = 0;
        this.Price = 0;
        this.MealQuantity = 0;
    }

    public Cat(string nickname, int age, string gender, double energy, double price, int mealquantity)
    {
        this.Nickname = nickname;
        this.Age = age;
        this.gender = gender;
        this.Energy = energy;
        this.Price = price;
        this.MealQuantity = mealquantity;
    }
    public override void Play()
    {
        if (this.Energy - 20 >= 0)
        {
            this.Energy -= 20;
        }
        else
        {
            this.Energy = 0;
        }
        Console.WriteLine(" Cat played ");
        if (this.Energy == 0)
        {
            this.Sleep();
        }
    }

    public override void Sleep()
    {
        if (Energy != 100)
        {
            if (this.Energy + 70 > 100)
            {
                this.Energy = 100;
            }
            else
            {
                this.Energy += 70;
            }
        }

        this.Price += 1;
        this.MealQuantity += 1;
        Console.WriteLine(" Cat sleeped ");
    }
    public override void Eat()
    {
        if (Energy != 100)
        {
            if (this.Energy + 10 > 100)
            {
                this.Energy = 100;
            }
            else
            {
                this.Energy += 10;
            }
        }
        this.Price += 1;
        this.MealQuantity += 1;
        Console.WriteLine(" Cat Eat ");
        
    }

}

class Dog : Animal
{
    public Dog()
    {
        this.Nickname = string.Empty;
        this.Age = 0;
        this.gender = string.Empty;
        this.Energy = 0;
        this.Price = 0;
        this.MealQuantity = 0;
    }

    public Dog(string nickname, int age, string gender, double energy, double price, int mealquantity)
    {
        this.Nickname = nickname;
        this.Age = age;
        this.gender = gender;
        this.Energy = energy;
        this.Price = price;
        this.MealQuantity = mealquantity;
    }
    public override void Play()
    {
        if (this.Energy - 20 >= 0)
        {
            this.Energy -= 20;
        }
        else
        {
            this.Energy = 0;
        }
        Console.WriteLine(" Dog played ");
        if (this.Energy == 0)
        {
            this.Sleep();
        }
    }

    public override void Sleep()
    {
        if (Energy != 100)
        {
            if (this.Energy + 70 > 100)
            {
                this.Energy = 100;
            }
            else
            {
                this.Energy += 70;
            }
        }

        this.Price += 1;
        this.MealQuantity += 1;
        Console.WriteLine(" Dog sleeped ");
    }
    public override void Eat()
    {
        if (Energy != 100)
        {
            if (this.Energy + 10 > 100)
            {
                this.Energy = 100;
            }
            else
            {
                this.Energy += 10;
            }
        }
        this.Price += 1;
        this.MealQuantity += 1;
        Console.WriteLine(" Dog Eat ");
    }

}

class Bird : Animal
{
    public Bird()
    {
        this.Nickname = string.Empty;
        this.Age = 0;
        this.gender = string.Empty;
        this.Energy = 0;
        this.Price = 0;
        this.MealQuantity = 0;
    }

    public Bird(string nickname, int age, string gender, double energy, double price, int mealquantity)
    {
        this.Nickname = nickname;
        this.Age = age;
        this.gender = gender;
        this.Energy = energy;
        this.Price = price;
        this.MealQuantity = mealquantity;
    }
    public override void Play()
    {
        if (this.Energy - 20 >= 0)
        {
            this.Energy -= 20;
        }
        else
        {
            this.Energy = 0;
        }
        Console.WriteLine(" Bird played ");
        if (this.Energy == 0)
        {
            this.Sleep();
        }
    }

    public override void Sleep()
    {
        if (Energy != 100)
        {
            if (this.Energy + 70 > 100)
            {
                this.Energy = 100;
            }
            else
            {
                this.Energy += 70;
            }
        }

        this.Price += 1;
        this.MealQuantity += 1;
        Console.WriteLine(" Bird sleeped ");
    }
    public override void Eat()
    {
        if (Energy != 100)
        {
            if (this.Energy + 10 > 100)
            {
                this.Energy = 100;
            }
            else
            {
                this.Energy += 10;
            }
        }
        this.Price += 1;
        this.MealQuantity += 1;
        Console.WriteLine(" Bird Eat ");
    }

}

class Fish : Animal
{
    public Fish()
    {
        this.Nickname = string.Empty;
        this.Age = 0;
        this.gender = string.Empty;
        this.Energy = 0;
        this.Price = 0;
        this.MealQuantity = 0;
    }

    public Fish(string nickname, int age, string gender, double energy, double price, int mealquantity)
    {
        this.Nickname = nickname;
        this.Age = age;
        this.gender = gender;
        this.Energy = energy;
        this.Price = price;
        this.MealQuantity = mealquantity;
    }
    public override void Play()
    {
        if (this.Energy - 20 >= 0)
        {
            this.Energy -= 20;
        }
        else
        {
            this.Energy = 0;
        }
        Console.WriteLine(" Fish played ");
        if (this.Energy == 0)
        {
            this.Sleep();
        }
    }

    public override void Sleep()
    {
        if (Energy != 100)
        {
            if (this.Energy + 70 > 100)
            {
                this.Energy = 100;
            }
            else
            {
                this.Energy += 70;
            }
        }

        this.Price += 1;
        this.MealQuantity += 1;
        Console.WriteLine(" Fish sleeped ");
    }
    public override void Eat()
    {
        if (Energy != 100)
        {
            if (this.Energy + 10 > 100)
            {
                this.Energy = 100;
            }
            else
            {
                this.Energy += 10;
            }
        }
        this.Price += 1;
        this.MealQuantity += 1;
        Console.WriteLine(" Fish Eat ");
    }

}

class PetShop
{
    public Cat[] cats;
    int cats_count;
    int max_cats = 10;
    public Dog[] dogs;
    int dogs_count;
    int max_dogs = 10;
    public Bird[] birds;
    int birds_count;
    int max_birds = 10;
    public Fish[] fishs;
    int fishs_count;
    int max_fishs = 10;

    public PetShop()
    {
        this.cats = new Cat[this.max_cats];
        this.dogs = new Dog[this.max_dogs];
        this.birds = new Bird[this.max_birds];
        this.fishs = new Fish[this.max_fishs];
        this.cats_count = 0;
        this.dogs_count = 0;
        this.fishs_count = 0;
        this.birds_count = 0;
    }

    //Methods: RemoveByNickName(), and etc.

    public void add_Cat(Cat new_cat)
    {
        this.cats[cats_count++] = new_cat;
    }
    public void add_Dog(Dog new_dog)
    {
        this.dogs[dogs_count++] = new_dog;
    }
    public void add_Bird(Bird new_bird)
    {
        this.birds[birds_count++] = new_bird;
    }
    public void add_Fish(Fish new_fish)
    {
        this.fishs[fishs_count++] = new_fish;
    }

    public void RemoveByNickName_cat(string nc)
    {
        for (int i = 0; i < this.cats_count; i++)
        {
            if (this.cats[i].Nickname == nc)
            {
                if (i != this.cats_count - 1)
                {
                    for (int j = i; j < this.cats_count - 1; j++)
                    {
                        this.cats[j] = cats[j + 1];
                    }
                }
                this.cats_count--;
            }
        }
    }

    public void RemoveByNickName_dog(string nc)
    {
        for (int i = 0; i < this.dogs_count; i++)
        {
            if (this.dogs[i].Nickname == nc)
            {
                if (i != this.dogs_count - 1)
                {
                    for (int j = i; j < this.dogs_count - 1; j++)
                    {
                        this.dogs[j] = dogs[j + 1];
                    }
                }
                this.dogs_count--;
            }
        }
    }

    public void RemoveByNickName_bird(string nc)
    {
        for (int i = 0; i < this.birds_count; i++)
        {
            if (this.birds[i].Nickname == nc)
            {
                if (i != this.birds_count - 1)
                {
                    for (int j = i; j < this.birds_count - 1; j++)
                    {
                        this.birds[j] = birds[j + 1];
                    }
                }
                this.birds_count--;
            }
        }
    }

    public void RemoveByNickName_fish(string nc)
    {
        for (int i = 0; i < this.fishs_count; i++)
        {
            if (this.fishs[i].Nickname == nc)
            {
                if (i != this.fishs_count - 1)
                {
                    for (int j = i; j < this.fishs_count - 1; j++)
                    {
                        this.fishs[j] = fishs[j + 1];
                    }
                }
                this.fishs_count--;
            }
        }
    }

    public void Show_all_cats()
    {
        for(int i = 0;i < this.cats_count; i++)
        {
            Console.WriteLine();
            cats[i].Show();
            Console.WriteLine();
        }
    }

    public void Show_all_dogs()
    {
        for (int i = 0; i < this.dogs_count; i++)
        {
            Console.WriteLine();
            dogs[i].Show();
            Console.WriteLine();
        }
    }
    public void Show_all_birds()
    {
        for (int i = 0; i < this.birds_count; i++)
        {
            Console.WriteLine();
            birds[i].Show();
            Console.WriteLine();
        }
    }

    public void Show_all_fishs()
    {
        for (int i = 0; i < this.fishs_count; i++)
        {
            Console.WriteLine();
            fishs[i].Show();
            Console.WriteLine();
        }
    }

    public void all_Prices()
    {
        
        double all_cats_price = 0;
        double all_dogs_price = 0;
        double all_birds_price = 0;
        double all_fishs_price = 0;

        for (int i = 0;i < this.cats_count; i++)
        {
            all_cats_price += this.cats[i].Price;
        }

        for (int i = 0;i < this.dogs_count; i++)
        {
            all_dogs_price += this.dogs[i].Price;
        }

        for (int i = 0;i < this.birds_count; i++)
        {
            all_birds_price += this.birds[i].Price;
        }

        for (int i = 0;i < this.fishs_count; i++)
        {
            all_fishs_price += this.fishs[i].Price;
        }

        Console.WriteLine($" All cats price : {all_cats_price}");
        Console.WriteLine($" All dogs price : {all_dogs_price}");
        Console.WriteLine($" All birds price : {all_birds_price}");
        Console.WriteLine($" All fishs price : {all_fishs_price}");

    }

    public void all_Foots()
    {
        int footCats = 0;
        int footDogs = 0;
        int footBirds = 0;
        int footFishs = 0;

        for (int i = 0; i < this.cats_count; i++)
        {
            footCats += this.cats[i].MealQuantity;
        }

        for (int i = 0; i < this.dogs_count; i++)
        {
            footDogs += this.dogs[i].MealQuantity;
        }

        for (int i = 0; i < this.birds_count; i++)
        {
            footBirds += this.birds[i].MealQuantity;
        }

        for (int i = 0; i < this.fishs_count; i++)
        {
            footFishs += this.fishs[i].MealQuantity;
        }

        Console.WriteLine($" All cats foot : {footCats}");
        Console.WriteLine($" All dogs foot : {footDogs}");
        Console.WriteLine($" All birds foot : {footBirds}");
        Console.WriteLine($" All fishs foot : {footFishs}");

    }

}


