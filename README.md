## Naxtor Games Attributes

Allows a number of additional attributes for fields.

### Attributes

- **ReadOnly**: Disables any interaction with the field.
- **DisplayAs**: Allows a custom name for the field. (A tooltip can also optionally be added but may conflict with [Unity’s Tooltip Attribute](https://docs.unity3d.com/ScriptReference/TooltipAttribute.html))
- **Required**: Highlights the field when the object reference is empty.
- **Button**: Adds a button below the field for simple actions.  
  - Does not work for static methods.  
  - Field is required to work.  
  - One button per field.  
  - By default, the execution mode is set to Always. Can also be set to PlayModeOnly or EditModeOnly.
- **Selectable**: Adds a button beside the field to quickly select the object reference in the scene.

### NOTE

The order of attributes *does* affect how the field is presented.
