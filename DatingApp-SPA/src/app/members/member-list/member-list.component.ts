import { Component, OnInit } from '@angular/core';
import { User } from '../../_models/user';
import { UserService } from '../../_services/user.service';
import { AlertifyService } from '../../_services/alertify.service';
import { ActivatedRoute } from '@angular/router';
import { PaginatedResult, Pagination } from 'src/app/_models/pagination';

@Component({
  selector: 'app-member-list',
  templateUrl: './member-list.component.html',
  styleUrls: ['./member-list.component.css'],
})
export class MemberListComponent implements OnInit {
  users: User[];
  pagination: Pagination;
  constructor(
    private userService: UserService,
    private aleetify: AlertifyService,
    private route: ActivatedRoute
  ) {}

  ngOnInit(): void {
    this.route.data.subscribe((d) => {
      console.log(d);

      this.pagination = d.users.pagination;
      this.users = d.users.result;
    });
  }

  pageChanged(event: any): void {
    this.pagination.currentPage = event.page;
    this.loadUsers();
  }

  loadUsers() {
    this.userService.getUsers(this.pagination.currentPage, this.pagination.itemsPerPage).subscribe(
      (res: PaginatedResult<User[]>) => {
        this.users = res.result;
        this.pagination = res.pagination;
      },
      (error) => this.aleetify.error(error)
    );
  }
}
