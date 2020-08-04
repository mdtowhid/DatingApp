import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { AuthService } from '../_services/auth.service';
import { AlertifyService } from '../_services/alertify.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css'],
})
export class RegisterComponent implements OnInit {
  constructor(
    private authService: AuthService,
    private alertify: AlertifyService
  ) {}

  @Output() cancelRegister = new EventEmitter();

  model: any = {};

  ngOnInit(): void {}

  register() {
    this.authService.register(this.model).subscribe(
      (response) => {
        this.alertify.success('success');
      },
      (err) => {
        this.alertify.error(err);
      }
    );
  }

  cancel() {
    this.cancelRegister.emit(false);
    console.log('cancel');
  }
}
