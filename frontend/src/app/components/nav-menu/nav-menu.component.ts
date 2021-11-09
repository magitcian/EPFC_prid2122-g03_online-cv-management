import { Component } from '@angular/core';
import { Member, Role } from '../../models/member';
import { AuthenticationService } from '../../services/authentication.service';
import { Router } from '@angular/router';

@Component({
    selector: 'app-nav-menu',
    templateUrl: './nav-menu.component.html',
    styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {
    isExpanded = false;

    constructor(
        private router: Router,
        public authenticationService: AuthenticationService
    ) { }

    collapse() {
        this.isExpanded = false;
    }

    toggle() {
        this.isExpanded = !this.isExpanded;
    }

    get currentUser() {
        return this.authenticationService.currentUser;
    }

    get isAdmin() {
        return this.currentUser && this.currentUser.role === Role.Admin;
    }

    logout() {
        this.authenticationService.logout();
        this.router.navigate(['/login']);
    }
}