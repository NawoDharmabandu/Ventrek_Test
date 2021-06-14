import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class LoginService {
  
  url="http://localhost:46653/api/Auth"
  constructor(private http:HttpClient) {
    console.log('TEST');
    
   }

  //calling the server to generate token
  generateToken(credentials:any){
  return this.http.post(`${this.url}/Token`,credentials,{responseType:'text'})
  }

  //for login user
  loginUser(token: string)
  {
    localStorage.setItem("token",token)
    return true;
  }

  storeUserID(userID: string)
  {
    localStorage.setItem("userID",userID)
    return true;
  }

  //to check that user login or not
  isLoggedIn()
  {
    let token=localStorage.getItem("token");
    if(token==undefined || token=== '' || token==null)
    {
      return false;

    }
    else {
      return true;
    }
  }

  

  //To logout the user
  logout ()
  {
    localStorage.removeItem('token')
    return true;
  }

  //for getting the token
  getToken()
  {
    return localStorage.getItem('token')
  }

}
