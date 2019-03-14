import { VehicleService } from '../../Services/vehicle.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-vehicle-form',
  templateUrl: './vehicle-form.component.html',
  styleUrls: ['./vehicle-form.component.css']
})
export class VehicleFormComponent implements OnInit {
  makes: any[];
  models: any[];
  vehicle: any = {};
  features: any[];
  constructor(
    private vehicleService: VehicleService
    ) { }

  ngOnInit() {
    this.vehicleService.getMakes().subscribe((makes: any[]) =>
    this.makes = makes
  );
  this.vehicleService.getFeatures().subscribe((features: any[]) =>
    this.features = features

  );

}

  onMakeChange() {
    const selectedMake = this.makes.find(x => x.id == this.vehicle.make);
    this.models = selectedMake ? selectedMake.models : [];
  }

}
