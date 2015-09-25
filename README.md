#My take on the Design pattern Observer#
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
# How to use ?

* Implement the Iobserver for the obervable object

* Create a new instance of an Observer Manager in the observed object

* Place the Notify function where it is needed

* Register/unregister 

# Objectif 

| Objectif  | Solution |
| ------------- | ------------- |
| Easy to use and simple | using class/interface to make instance for having less code to write   |
| Reusable | Using generic typing + no multi inheritance (c# doesn’t support it)  |



# Why ?

The Observer pattern is used when there is one-to-many relationship between objects such as if one object

is modified, its dependent objects are to be notified automatically. The Observer pattern falls under the 

behavioral pattern category. Think for example of twitter, followers are the observers and the followed channels 

are the ones being observed.

# Example

Simply clone my project and test my pattern. To me, real life example is always easier to understand. 

That is why I use an electricity example. In the project I created 2 custom components: a "Switch"

and a "light". You simply register a switch to a light to make it react to it.

 

![alt tag](https://raw.githubusercontent.com/JGLaferte/Observer/master/ObserverPat/ObserverPattern/Img/Observer.gif)

(Switch1 is registered to light 1 and 2)
(Switch2 is registered to light 2 and 3)



  
