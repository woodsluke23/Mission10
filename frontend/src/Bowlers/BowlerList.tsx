import { useEffect, useState } from 'react';
import { Bowler } from '../types/Bowler';

function BowlerList() {
  const [bowlData, setBowlData] = useState<Bowler[]>([]);

  useEffect(() => {
    const fetchdata = async () => {
      const rsp = await fetch('http://localhost:5094/Bowlers');
      const b = await rsp.json();
      setBowlData(b);
    };
    fetchdata();
  }, []);

  return (
    <>
      <div className="row">
        <h2 className="text-center">Check them out!</h2>
      </div>
      <br />
      <br />
      <table className="table table-bordered">
        <thead>
          <tr>
            <th>Bowler Name</th>
            <th>Team Name</th>
            <th>Address</th>
            <th>City</th>
            <th>State</th>
            <th>Zip</th>
            <th>Phone Number</th>
          </tr>
        </thead>
        <tbody>
          {bowlData.map((b) => (
            <tr key={b.bowlerID}>
              <td>
                {b.bowlerFirstName}, {b.bowlerMiddleInit}, {b.bowlerLastName}
              </td>
              <td>{b.teams.teamName}</td>
              <td>{b.bowlerAddress}</td>
              <td>{b.bowlerCity}</td>
              <td>{b.bowlerState}</td>
              <td>{b.bowlerzip}</td>
              <td>{b.bowlerPhoneNumber}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
}

export default BowlerList;
