import { Component, OnInit } from '@angular/core';
import { AuthService } from './_services/auth.service';
import { JwtHelperService } from '@auth0/angular-jwt';
import { User } from './_models/user';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent implements OnInit {
  title = 'App';
  jwtHelper = new JwtHelperService();

  constructor(private authService: AuthService) {}
  ngOnInit() {
    const token = window.localStorage.getItem('token');
    if (token) {
      this.authService.decodedToken = this.jwtHelper.decodeToken(token);
    }

    const user: User = JSON.parse(window.localStorage.getItem('user'));
    if (user) {
      this.authService.currentUser = user;
      this.authService.changePhotoUrl(user.photoUrl);
    }
  }
}
