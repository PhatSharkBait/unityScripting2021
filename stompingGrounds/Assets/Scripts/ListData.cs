using System.Collections.Generic;
using UnityEngine;

public class ListData : MonoBehaviour {
   public List<GameObject> gameObjectList;

   public void AddObjectToList(GameObject newObject) {
      gameObjectList.Add(newObject);
   }

   public void RemoveObjectFromList(GameObject objectToRemove) {
      gameObjectList.Remove(objectToRemove);
   }
}
