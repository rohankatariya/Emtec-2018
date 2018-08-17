import { Injectable } from '@angular/core';
import { Hero } from './Hero';
import { Heroes } from './IndependenceHeroes';
import { Observable, of } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class HeroService {
  constructor() { }
  getHeroes(): Observable<Hero[]> {
    return of(Heroes);
  }
  getHero(id : number):Observable<Hero>{
    return of(Heroes.find(hero=>hero.id==id));
  }
}
