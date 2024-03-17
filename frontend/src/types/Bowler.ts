export type Bowler = {
  bowlerID: number;
  bowlerLastName: string;
  bowlerFirstName: string;
  bowlerMiddleInit: string;
  bowlerAddress: string;
  bowlerCity: string;
  bowlerState: string;
  bowlerzip: string;
  bowlerPhoneNumber: string;
  teamID: number;
  teams: {
    teamdId: number;
    teamName: string;
  };
};
