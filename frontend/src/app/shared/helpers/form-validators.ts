import { FormGroup, ValidatorFn } from '@angular/forms';

export function notEqualValidator(thisKey: string, thatKey: string) : ValidatorFn {
  return (group: FormGroup): {[key: string]: any} => {
    const thisControl = group.controls[thisKey];
    const thatControl = group.controls[thatKey];
    if (thisControl.touched && thatControl.touched) {
      const isEqual = thisControl.value === thatControl.value;
      
      if (isEqual && thisControl.valid && thatControl.valid) {
        thisControl.setErrors({notEqual: thatKey});
        return {'notEqual': `${thisKey} must be different from ${thatKey}`};
      }
      if (!isEqual && thatControl.hasError('notEqual')) {
        thatControl.setErrors(null);
      }
    }

    return null;
  };
}