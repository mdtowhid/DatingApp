import { Injectable } from '@angular/core';
import { CanDeactivate } from '@angular/router';
import { MemeberEditComponent } from '../members/memeber-edit/memeber-edit.component';

@Injectable({
  providedIn: 'root',
})
export class PreventUnsavedChanges
  implements CanDeactivate<MemeberEditComponent> {
  canDeactivate(component: MemeberEditComponent) {
    if (component.editForm.dirty) {
      return confirm(
        'Are you sure you want to continue? Any unsaved changes will be lost.'
      );
    }

    return false;
  }
}
