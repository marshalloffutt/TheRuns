import { AppBar, Toolbar, IconButton, Typography } from "@mui/material";
import DirectionsRunIcon from "@mui/icons-material/DirectionsRun";

export const Navbar = () => {
  return (
    <AppBar position="static">
      <Toolbar>
        <IconButton size="large" edge="start" color="inherit" area-label="logo">
          <DirectionsRunIcon />
        </IconButton>
        <Typography variant="h6" component="div">
          The Runs
        </Typography>
      </Toolbar>
    </AppBar>
  );
};
