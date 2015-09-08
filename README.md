#My take on the Design pattern  Observer
```csharp

        public class ObserverManager
        {


            List<Iobserver> obsList = new List<Iobserver>();
            public void register(Iobserver ob)
            {
                obsList.Add(ob);
            }
            public void unRegister(Iobserver ob)
            {
                obsList.Remove(ob);

            }
            public void Notify<S>(S state)
            {
                foreach (Iobserver ob in obsList)
                {
                    ob.update(state);
                }
            }
        }
        public interface Iobserver
        {
            void update<S>(S sub);

        }
```
# Ho to use ?

* Implement the Iobserver for the obervable object

* Create a new instence of Observer Manager in the observed object

* Place the Notify function where is needed

* Register/unregister 

# Objectif 

| Objectif  | Solution |
| ------------- | ------------- |
| Easy to use and simple  |  using class/interface for make instance for having less code to write   |
| Reusable  | Using generic typing + no multi hineritense (c# dont support it)  |



# Why ?

Observer pattern is used when there is one-to-many relationship between objects such as if one object is modified, its

depenedent objects are to be notified automatically. Observer pattern falls under behavioral pattern category.

Think for exemple of twitter, followers is the observer and the followed is to one being observed.

# Exemple

Simple clone my project and test my pattern.

To me , real life exemple is alway easyer to undestand.That why i used the electicity for the exemple.

In the project i created 2 custom componennt : "Switch" and "light".

You simply register a switch to a light to make it react to it.



![alt tag](https://raw.githubusercontent.com/JGLaferte/Observer/master/lightExemple.png)

(switch1 is registered to light 1 and 2)



  
