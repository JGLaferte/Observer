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

* 1.Implement the Iobserver for the obervable object

* 2.Create a new instence of Observer Manager in the observed object

* 3.Place the Notify function where is needed

* 4.Register/unregister 

# Objectif 

* Easy to use and simple
* Reusable

# Why ?

# Exemple
Simple clone my project and test my pattern.

To me , real life exemple is alway easyer to undestand.That why i used the electicity for the exemple.

In the project i created 2 custom componennt : "Switch" and "light".

You simply register a switch to a light to make it react to it.






  
