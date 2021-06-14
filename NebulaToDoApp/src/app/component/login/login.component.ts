import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { LoginService } from 'src/app/shared/login.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  credentials={
    useR_ID:'',
    useR_PASSWORD:'',
  }
  
  constructor(private loginService:LoginService, private router:Router) { }

  ngOnInit(): void {
    
  }

  onSubmit()
  {
    if((this.credentials.useR_ID!='' && this.credentials.useR_PASSWORD!='')&& (this.credentials.useR_ID!=null && this.credentials.useR_PASSWORD!=null ))
    {
      this.loginService.generateToken(this.credentials).subscribe(
        (response:any)=>{
          console.log(response);
          this.router.navigateByUrl('/taskdetails');
          
        },
        //error
        error=>{
        console.log(error);
        }
      )
      

    }else
    console.log("Fields are empty");  
  
  }

}
