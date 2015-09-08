# Observer
My take on the Design pattern : Observer
------------------------------------------
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
```
        public interface Iobserver
        {
            void update<S>(S sub);

        }
  
