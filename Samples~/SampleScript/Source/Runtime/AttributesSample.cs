using UnityEngine;

namespace NaxtorGames.Attributes.Samples
{
    public sealed class AttributesSample : MonoBehaviour
    {
#pragma warning disable CS0414 // Disables compiler warnings for unused fields.
        [Header("ReadOnly")]
        [ReadOnly]
        [SerializeField] private float _readOnlyValue = 2.56f;

        [Header("Selectable")]
        [Selectable]
        [SerializeField] private GameObject _selectableObject = null;

        [Header("DisplayAs")]
        [DisplayAs("Overriden Display", "This text field also has a tooltip now.")]
        [SerializeField] private string _someText = "Some Text";

        [Header("Required")]
        [Required]
        [SerializeField] private Transform _requiredTransform = null;

        [Header("Buttons")]
        [Button("Print ReadOnly Value", nameof(PrintReadOnlyValue))]
        [SerializeField] private bool _alwaysClickable = false;
        [Button("Print ReadOnly Value", nameof(PrintReadOnlyValue), ButtonExecutionMode.PlayModeOnly)]
        [SerializeField] private bool _inPlayModeClickable = false;
        [Button("Print ReadOnly Value", nameof(PrintReadOnlyValue), ButtonExecutionMode.EditModeOnly)]
        [SerializeField] private bool _inEditModeClickable = false;

        [Header("Order Dose Matter")]
        [ReadOnly, Selectable]
        [SerializeField] private GameObject _readOnlyFirst = null;
        [Selectable, ReadOnly]
        [SerializeField] private GameObject _readOnlyLast = null;
        [Required, Selectable]
        [SerializeField] private GameObject _requiredFirst = null;
        [Selectable, Required]
        [SerializeField] private GameObject _requiredLast = null;
#pragma warning restore CS0414

        private void Reset()
        {
            _readOnlyLast = this.gameObject;
            _readOnlyFirst = this.gameObject;
        }

        private void PrintReadOnlyValue()
        {
            Debug.Log($"The value is: {_readOnlyValue}");
        }

    }
}
