import { Component, OnInit, Input } from '@angular/core';
import { User } from 'src/app/_models/user';
import { AlertifyService } from 'src/app/_services/alertify.service';
import { AuthService } from 'src/app/_services/auth.service';
import { UserService } from 'src/app/_services/user.service';

@Component({
  selector: 'app-memeber-card',
  templateUrl: './memeber-card.component.html',
  styleUrls: ['./memeber-card.component.css'],
})
export class MemeberCardComponent implements OnInit {
  @Input() user: User;

  constructor(
    public authService: AuthService,
    private userService: UserService,
    private alertifyService: AlertifyService
  ) {}

  ngOnInit() {}

  sendLike(id: number) {
    this.userService
      .sendLike(this.authService.decodedToken.nameid, id)
      .subscribe(
        (data) =>
          this.alertifyService.success('You have liked: ' + this.user.knownAs),
        (error) => this.alertifyService.error(error)
      );
  }
}
