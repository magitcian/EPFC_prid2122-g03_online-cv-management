
import { Component, AfterViewInit, Input } from '@angular/core';
import * as _ from 'lodash-es';
import { UserService } from '../../services/user.service';
import { User } from 'src/app/models/user';
import { Mission } from 'src/app/models/mission';
import { AuthenticationService } from '../../services/authentication.service';

@Component({
    selector: 'app-cv-view',
    templateUrl: './cv-view.component.html'
})
export class CvViewComponent implements AfterViewInit {
    @Input() set getUserID(val: number) {
        this.userID = val;
        this.getInfoCV();
    }
    userID !: number;

    missions: Mission[] = [];

    constructor(private userService: UserService, public authenticationService: AuthenticationService) {

    }

    ngAfterViewInit(): void {
        this.getInfoCV();
    }

    getInfoCV() {
        if (this.userID == null) {
            this.userID = this.authenticationService.currentUser?.id!;
        }
        this.userService.getMissions(this.userID).subscribe(missions => {
            this.missions = missions;
        });

    }


}
