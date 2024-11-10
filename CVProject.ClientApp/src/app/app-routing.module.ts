import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AboutComponent } from './about/about.component';
import { ExperienceComponent } from './experience/experience.component';
import { EducationComponent } from './education/education.component';
import { ProjectComponent } from './project/project.component';
import { SkillsComponent } from './skills/skills.component';

const routes: Routes = [
  {path:'About', component:AboutComponent},
  {path:'Experience',component:ExperienceComponent},
  {path:'Education',component:EducationComponent},
  {path:'Projects',component:ProjectComponent},
  {path:'Skills',component:SkillsComponent},
  {path:'',component:AboutComponent},
  /* {path:'',redirectTo:'About',pathMatch:'full'}, */
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
