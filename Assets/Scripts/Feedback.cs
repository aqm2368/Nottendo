using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public interface Feedback : ISelectHandler, ISubmitHandler, IDeselectHandler, IPointerEnterHandler, IPointerClickHandler, IPointerExitHandler
{}