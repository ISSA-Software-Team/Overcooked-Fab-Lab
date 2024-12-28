// using UnityEngine;

// public class InteractDetector : MonoBehaviour
// {

//     private List<Interactable> _interactablesInRange = new List<Interactable>();



//     // Update is called once per frame
//     void Update()
//     {
//         if(Input.GetButtonDown("Interact")) && _interactablesInRange.Count > 0) {
//             var interactable = _interactablesInRange[0];
//             interactable.Interact();
//             if(!interactable.CanInteract()) {
//                 _interactablesInRange.Remove(interactable);
//             }
//         }
//     }

//     private void private void OnTriggerEnter(Collider other) {
//         var interactable = other.GetComponent<Interactable>();
//         if(interactable != null && interactable.CanInteract()) {
//             _interactablesInRange.Add(interactable);
//         }
//     }

//     private void private void OnTriggerExit(Collider other) {
//         var interactable = other.GetComponent<Interactable>();
//         if(_interactablesInRange.Contains(interactable)) {
//             _interactablesInRange.Remove(interactable);
//         }
//     }
// }
