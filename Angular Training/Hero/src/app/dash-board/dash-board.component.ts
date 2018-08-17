import { Component, OnInit } from '@angular/core';
import { Hero } from '../Hero';
import { HeroService } from '../hero.service';
@Component({
  selector: 'app-dash-board',
  templateUrl: './dash-board.component.html',
  styleUrls: ['./dash-board.component.css']
})
export class DashBoardComponent implements OnInit {

  heroes : Hero[] = [];
  constructor(private heroSrevice : HeroService) { }

  ngOnInit() {
  }
  getHeroes()
  {
    this.heroSrevice.getHeroes()
    .subscribe(heroes => this.heroes = heroes.slice(1,5));
  }
}
