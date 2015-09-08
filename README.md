#My take on the Design pattern  Observer


Pattern : 
```c#

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

- [x] 2.Create a new instence of Observer Manager in the observed object

- [x] 3.Place the Notify function where is needed

- [x] 4.Register/unregister 

# Objectif 
Easy to use and simple Pattern




  
