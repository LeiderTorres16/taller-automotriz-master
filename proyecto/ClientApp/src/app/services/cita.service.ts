import { HttpClient } from '@angular/common/http';
import { Inject,Injectable } from '@angular/core';
import {Cita} from '../models/Cita';
import { catchError, tap } from 'rxjs/operators';
import { Observable,of } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class CitaService {
  baseURL:string;
  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') baseUrl: string) {
      this.baseURL=baseUrl;

     }

     get():Observable<Cita[]>{     
      return this.http.get<Cita[]>(this.baseURL+'api/cita').pipe(
        tap(),
        catchError(error=>{
          console.log('se ha presentado un error al registrar los datos')
          return of(error as Cita[])
        })
      );
      
      }

      post(cita:Cita):Observable<Cita>{    
        //return this.http.post<Persona>(this.baseURL+'api/persona',persona).pipe(
          return this.http.post<Cita>(this.baseURL+'api/cita',cita).pipe(
          tap(_=>console.log("Los datos se guardaron Satisfactoriamente")),
          catchError(error=>{
            console.log('se ha presentado un error al registrar los datos')
            return of(cita)
          })
        )
      }
}
