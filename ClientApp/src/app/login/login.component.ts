import { Component } from '@angular/core';
import { AuthService } from '../_services/auth.service';
import { error } from '@angular/compiler/src/util';

@Component({
    selector: 'app-login',
    templateUrl: './login.component.html'
   
})
/** Login component*/
export class LoginComponent {
  /** Login ctor */
  model: any = {};
  constructor(private authService: AuthService) {

  }

  ngOnInit() {

  }

  login() {
    this.authService.login(this.model).subscribe(next => {
      console.log('Logged in Sucessfully');
    },
      error => {
        console.log('Failed to Login');
      }
    );
  }
}
